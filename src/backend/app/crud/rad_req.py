from models.rad_req import Rad_ReqDB
from models.rad_req_detail import Rad_ReqDetailDB
from schemas.rad_req import Rad_ReqCreate
from sqlalchemy.orm import Session
from fastapi import HTTPException
import uuid


def get_rad_reqs(db: Session):
    return db.query(Rad_ReqDB).all()

def create_rad_req(db: Session, req: Rad_ReqCreate):
    rad_req = Rad_ReqDB(
        rad_req_id=gen_rad_req_id(db),
        hn=req.hn,
        emp_id=req.emp_id,
        rad_req_date=req.rad_req_date,
        rad_req_impression=req.rad_req_impression,
        rad_req_history=req.rad_req_history,
        rad_req_urgency_level=req.rad_req_urgency_level,
        rad_req_status="pending"
    )
    db.add(rad_req)
    db.flush()

    last = (
        db.query(Rad_ReqDetailDB.rad_detail_id)
        .order_by(Rad_ReqDetailDB.rad_detail_id.desc())
        .first()
    )

    start = int(last[0][6:]) if last else 0

    for i, d in enumerate(req.details, start=1):
        detail = Rad_ReqDetailDB(
            rad_detail_id=f"rad_dt{start+i:04d}",
            rad_req_id=rad_req.rad_req_id,
            rad_test_id=d.rad_test_id,
            precaution=d.precaution,
            otherpart=d.otherpart
        )
        db.add(detail)

    db.commit()
    return rad_req


def update_rad_req(rad_req_id:str, rad_req:Rad_ReqCreate, db:Session):
    db_rad_req = db.query(Rad_ReqDB).filter(Rad_ReqDB.rad_req_id == rad_req_id).first()
    if not db_rad_req:
        raise HTTPException(status_code=404,detail="Rad_Req not found")
    for key,value in rad_req.dict().items():
        setattr(db_rad_req,key,value)
    db.commit()
    db.refresh(db_rad_req)
    return db_rad_req

def delete_rad_req(rad_req_id:str,db:Session):
    db_rad_req = db.query(Rad_ReqDB).filter(Rad_ReqDB.rad_req_id == rad_req_id).first()
    if not db_rad_req:
        raise HTTPException(status_code=404,detail="Rad_Req not found")
    db.delete(db_rad_req)
    db.commit()
    return {"Message": "Rad_Req deleted"}

def gen_rad_req_id(db: Session):
    return f"rad_rq{uuid.uuid4().hex[:4]}"