from models.employee import EmployeeDB
from schemas.employee import EmployeeCreate
from sqlalchemy.orm import Session
from fastapi import HTTPException
from models.department import DepartmentDB

def get_employees(db: Session):
    employees = (
        db.query(EmployeeDB,DepartmentDB.dept_name)
        .join(DepartmentDB,EmployeeDB.dept_id == DepartmentDB.dept_id)
        .all()
    )
    result = []
    for employee,dept_name in employees:
        result.append({
            "emp_id": employee.emp_id,
            "emp_fname": employee.emp_fname,
            "emp_lname": employee.emp_lname,
            "emp_tel": employee.emp_tel,
            "position_id": employee.position_id,
            "dept_name": dept_name,
            "password": employee.password
        })
        return result

def create_employee(employee: EmployeeCreate,db:Session):
    db_employee = EmployeeDB(**employee.dict())
    db.add(db_employee)
    db.commit()
    db.refresh(db_employee)
    return db_employee

def update_employee(emp_id:str, employee:EmployeeCreate, db:Session):
    db_employee = db.query(EmployeeDB).filter(EmployeeDB.emp_id == emp_id).first()
    if not db_employee:
        raise HTTPException(status_code=404,detail="Employee not found")
    for key,value in employee.dict().items():
        setattr(db_employee,key,value)
    db.commit()
    db.refresh(db_employee)
    return db_employee

def delete_employee(emp_id:str,db:Session):
    db_employee = db.query(EmployeeDB).filter(EmployeeDB.emp_id == emp_id).first()
    if not db_employee:
        raise HTTPException(status_code=404,detail="Employee not found")
    db.delete(db_employee)
    db.commit()
    return {"Message": "Employee deleted"}

def authenticate_employee(emp_fname:str,password:str,db: Session):
    return (
        db.query(EmployeeDB,DepartmentDB.dept_name).join(DepartmentDB,
        EmployeeDB.dept_id == DepartmentDB.dept_id).filter(EmployeeDB.emp_fname == emp_fname
        ,EmployeeDB.password == password).first()
    )