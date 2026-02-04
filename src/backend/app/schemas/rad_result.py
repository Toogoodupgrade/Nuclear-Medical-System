from pydantic import BaseModel
from datetime import datetime

class RadResultCreate(BaseModel):
    rad_req_id:str
    rad_machine_id: str
    rad_res_date: datetime
    rad_res_findings_text: str | None
    rad_res_impression: str | None

class RadResultUpdate(BaseModel):
    rad_res_findings_text: str | None
    rad_res_impression: str | None
    rad_res_status: str | None

class RadResultDataGrid(BaseModel):
    rad_res_id:str
    hn: str
    pt_fname: str
    pt_lname: str
    emp_fname: str
    emp_lname: str
    machine_name: str
    rad_res_date: datetime
    rad_res_status: str

    class Config:
        from_attributes = True

class RadResultDetail(BaseModel):
    rad_res_findings_text: str | None
    rad_res_impression: str | None
    rad_res_image: str | None

    class Config:
        from_attributes = True