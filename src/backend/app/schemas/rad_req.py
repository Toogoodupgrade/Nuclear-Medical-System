from datetime import datetime
from pydantic import BaseModel

from schemas.rad_req_detail import Rad_ReqDetailCreate

class Rad_ReqCreate(BaseModel):
    hn:str
    emp_id:str
    rad_req_date:datetime
    rad_req_impression:str | None = None
    rad_req_history:str | None = None
    rad_req_urgency_level:str
    details: list[Rad_ReqDetailCreate]

class Rad_Req(Rad_ReqCreate):
    class Config:
        from_attributes = True