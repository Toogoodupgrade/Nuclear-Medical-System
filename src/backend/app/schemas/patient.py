from datetime import datetime
from pydantic import BaseModel

class PatientCreate(BaseModel):
    hn:str
    pt_fname:str
    pt_lname:str
    pt_tel:str
    pt_gender:str
    pt_level:str
    pt_dob:datetime
    pt_medical_condition:str
    right_name:str
    pt_affiliation:str

class Patient(PatientCreate):
    class Config:
        from_attributes = True
        json_encoders = {
            datetime: lambda v: v.isoformat()
        }

class PatientSearch(BaseModel):
    hn: str
    pt_fname: str
    pt_lname: str

    class Config:
        from_attributes = True
