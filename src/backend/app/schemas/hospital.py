from pydantic import BaseModel

class HospitalRead(BaseModel):
    hospital_id: str
    hospital_name: str

    class Config:
        from_attributes = True