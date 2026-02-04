from pydantic import BaseModel
from datetime import datetime
from typing import Optional

class LabResultDataGrid(BaseModel):
    lab_res_id:str
    hn: str
    pt_fname: str
    pt_lname: str
    emp_fname: str
    emp_lname: str
    lab_test_name: str
    lab_test_category: str | None
    examtp: str | None
    method: str | None
    container: str | None
    volume: str | None
    lab_res_date: datetime
    lab_res_status: str | None

    class Config:
        from_attributes = True

class LabResultDetail(BaseModel):
    lab_res_diagnosis: str | None
    lab_res_summary: str | None

    class Config:
        from_attributes = True