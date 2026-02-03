from datetime import datetime
from pydantic import BaseModel

class EmployeeCreate(BaseModel):
    emp_id:str
    emp_fname:str
    emp_lname:str
    emp_tel:str
    position_id:str
    dept_name:str

class Employee(EmployeeCreate):
    class Config:
        from_attributes = True

class LoginRequest(BaseModel):
    emp_fname: str
    password: str