from models.lab_req import Lab_ReqDB
from models.lab_req_detail import Lab_ReqDetailDB
from schemas.lab_req import Lab_ReqCreate
from sqlalchemy.orm import Session
from fastapi import HTTPException
import uuid

def get_lab_reqs(db: Session):
    return db.query(Lab_ReqDB).all()

def create_lab_req(req: Lab_ReqCreate,db:Session):
    lab_req = Lab_ReqDB(
        lab_req_id = gen_lab_req_id(db),
        emp_id = req.emp_id,
        hn = req.hn,
        lab_req_date = req.lab_req_date,
        lab_req_status = "pending",
    )
    db.add(lab_req)
    db.flush()

    last = (
        db.query(Lab_ReqDetailDB.lab_detail_id)
        .order_by(Lab_ReqDetailDB.lab_detail_id.desc())
        .first()
    )
    start = int(last[0][6:]) if last else 0

    for i, d in enumerate(req.details,start=1):
        detail = Lab_ReqDetailDB(
            lab_detail_id = f"lab_dt{start+i:04d}",
            lab_req_id = lab_req.lab_req_id,
            lab_test_id = d.lab_test_id,
            examtp = d.examtp,
            other = d.other,
        )
        db.add(detail)
    db.commit()
    return lab_req

def update_lab_req(lab_req_id:str, lab_req:Lab_ReqCreate, db:Session):
    db_lab_req = db.query(Lab_ReqDB).filter(Lab_ReqDB.lab_req_id == lab_req_id).first()
    if not db_lab_req:
        raise HTTPException(status_code=404,detail="Lab_req not found")
    for key,value in lab_req.dict().items():
        setattr(db_lab_req,key,value)
    db.commit()
    db.refresh(db_lab_req)
    return db_lab_req

def delete_lab_req(lab_req_id:str,db:Session):
    db_lab_req = db.query(Lab_ReqDB).filter(Lab_ReqDB.lab_req_id == lab_req_id).first()
    if not db_lab_req:
        raise HTTPException(status_code=404,detail="Lab_req not found")
    db.delete(db_lab_req)
    db.commit()
    return {"Message": "Lab_req deleted"}

def gen_lab_req_id(db:Session):
    return f"lab_rq{uuid.uuid4().hex[:4]}"

