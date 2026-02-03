from datetime import datetime
from pydantic import BaseModel

from schemas.lab_req_detail import Lab_ReqDetailCreate

class Lab_ReqCreate(BaseModel):
    emp_id:str
    hn:str
    lab_req_date:datetime
    details: list[Lab_ReqDetailCreate]

class Lab_Req(Lab_ReqCreate):
    class Config:
        from_attributes = True