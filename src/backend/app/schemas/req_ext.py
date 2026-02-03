from datetime import datetime
from pydantic import BaseModel
from schemas.lab_req_detail import Lab_ReqDetailCreate

class Req_ExtCreate(BaseModel):
    emp_id :str
    hn: str
    lab_req_date: datetime
    hospital_id :str
    details: list[Lab_ReqDetailCreate]

class Req_Ext(Req_ExtCreate):
    class Config:
        from_attributes = True

class Req_ExtRead(BaseModel):
    request_external_id: str
    lab_req_id: str
    hospital_id: str | None
    request_status: str | None
    receive_date: datetime | None
    class Config:
        from_attributes = True