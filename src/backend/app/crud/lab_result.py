from sqlalchemy.orm import Session
from models.lab_result import Lab_ResultDB
from models.patient import PatientDB
from models.employee import EmployeeDB
from models.lab_req import Lab_ReqDB
from models.lab_test import Lab_TestDB
from models.lab_req_detail import Lab_ReqDetailDB
import uuid

def get_lab_result_detail(lab_res_id: str,db: Session):
    return (
         db.query(Lab_ResultDB)
    .filter(Lab_ResultDB.lab_res_id == lab_res_id)
    .first()
    )

def get_lab_result_by_hn(hn:str,db:Session):
    return (
        db.query(
            Lab_ResultDB.lab_res_id,
            PatientDB.hn,
            PatientDB.pt_fname,
            PatientDB.pt_lname,
            EmployeeDB.emp_fname,
            EmployeeDB.emp_lname,
            Lab_TestDB.lab_test_name,
            Lab_TestDB.lab_test_category,
            Lab_ReqDetailDB.examtp,
            Lab_TestDB.method,
            Lab_TestDB.container,
            Lab_TestDB.volume,
            Lab_ResultDB.lab_res_date,
            Lab_ResultDB.lab_res_status
        )
        .join(EmployeeDB, Lab_ResultDB.emp_id == EmployeeDB.emp_id)
        .join(Lab_ReqDB, Lab_ResultDB.lab_req_id == Lab_ReqDB.lab_req_id)
        .join(PatientDB, Lab_ReqDB.hn == PatientDB.hn)
        .join(Lab_ReqDetailDB,Lab_ReqDB.lab_req_id == Lab_ReqDetailDB.lab_req_id)
        .join(Lab_TestDB,Lab_ReqDetailDB.lab_test_id == Lab_TestDB.lab_test_id)
        .filter(PatientDB.hn == hn)
        .all()
    )

def gen_lab_res_id():
    return f"labres{uuid.uuid4().hex[:4]}"
