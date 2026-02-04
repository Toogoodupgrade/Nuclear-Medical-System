from schemas.rad_result import RadResultCreate
from sqlalchemy.orm import Session
from models.rad_result import Rad_ResultDB
from models.patient import PatientDB
from models.employee import EmployeeDB
from models.rad_machine import Rad_MachineDB
from models.rad_req import Rad_ReqDB
import uuid
from datetime import datetime

def get_rad_result_detail(rad_res_id: str,db: Session):
    return (
         db.query(Rad_ResultDB)
    .filter(Rad_ResultDB.rad_res_id == rad_res_id)
    .first()
    )

def create_rad_result(req: RadResultCreate,emp_id: str,db:Session):
    rad = Rad_ResultDB(
        rad_res_id = gen_rad_res_id(),
        rad_req_id = req.rad_req_id,
        emp_id = emp_id,
        rad_machine_id = req.rad_machine_id,
        rad_res_date = datetime.now(),
        rad_res_findings_text = req.rad_res_findings_text,
        rad_res_impression = req.rad_res_impression,
        rad_res_status = "completed"
    )
    db.add(rad)
    db.commit()
    db.refresh(rad)
    return rad

def get_rad_result_by_hn(hn:str,db:Session):
    return (
        db.query(
            Rad_ResultDB.rad_res_id,
            PatientDB.hn,
            PatientDB.pt_fname,
            PatientDB.pt_lname,
            EmployeeDB.emp_fname,
            EmployeeDB.emp_lname,
            Rad_MachineDB.machine_name,
            Rad_ResultDB.rad_res_date,
            Rad_ResultDB.rad_res_status
        )
        .join(EmployeeDB, Rad_ResultDB.emp_id == EmployeeDB.emp_id)
        .join(Rad_MachineDB, Rad_ResultDB.rad_machine_id == Rad_MachineDB.rad_machine_id)
        .join(Rad_ReqDB, Rad_ResultDB.rad_req_id == Rad_ReqDB.rad_req_id)
        .join(PatientDB, Rad_ReqDB.hn == PatientDB.hn)
        .filter(PatientDB.hn == hn)
        .all()
    )


def update_rad_result(rad_res_id, req,db: Session):
    rad = db.query(Rad_ResultDB)\
            .filter(Rad_ResultDB.rad_res_id == rad_res_id)\
            .first()
    for k, v in req.dict(exclude_unset=True).items():
            setattr(rad, k, v)

    db.commit()
    return rad


def gen_rad_res_id():
    return f"radres{uuid.uuid4().hex[:4]}"
