from models.req_ext import Req_ExtDB
from models.lab_req import Lab_ReqDB
from models.lab_req_detail import Lab_ReqDetailDB
from schemas.req_ext import Req_ExtCreate
from sqlalchemy.orm import Session
from fastapi import HTTPException
import uuid

def get_req_exts(db: Session):
    return db.query(Req_ExtDB).all()

def create_req_ext(req: Req_ExtCreate,db:Session):
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

    req_ext = Req_ExtDB(
        request_external_id = gen_request_external_id(db),
        lab_req_id = lab_req.lab_req_id,
        hospital_id = req.hospital_id,
        request_status = "pending",
        receive_date = None,
    )
    db.add(req_ext)
    db.commit()
    return req_ext

def update_req_ext(request_external_id:str, req_ext:Req_ExtCreate, db:Session):
    db_req_ext = db.query(Req_ExtDB).filter(Req_ExtDB.request_external_id == request_external_id).first()
    if not db_req_ext:
        raise HTTPException(status_code=404,detail="Req_ext not found")
    for key,value in req_ext.dict().items():
        setattr(db_req_ext,key,value)
    db.commit()
    db.refresh(db_req_ext)
    return db_req_ext

def delete_req_ext(request_external_id:str,db:Session):
    db_req_ext = db.query(Req_ExtDB).filter(Req_ExtDB.request_external_id == request_external_id).first()
    if not db_req_ext:
        raise HTTPException(status_code=404,detail="Req_ext not found")
    db.delete(db_req_ext)
    db.commit()
    return {"Message": "Req_ext deleted"}

def gen_request_external_id(db:Session):
    return f"rq_ext{uuid.uuid4().hex[:4]}"

def gen_lab_req_id(db:Session):
    return f"lab_rq{uuid.uuid4().hex[:4]}"
