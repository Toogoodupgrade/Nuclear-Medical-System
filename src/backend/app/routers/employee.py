from fastapi import Depends,APIRouter,HTTPException
from database import get_db
from sqlalchemy.orm import Session
from schemas.employee import Employee,EmployeeCreate,LoginRequest
from crud import employee as crud_employee

router = APIRouter(prefix="/employees",tags=["Employees"])

@router.get("/",response_model=list[Employee])
def get_employees(db=Depends(get_db)):
    return crud_employee.get_employees(db)

@router.post("/",response_model=Employee)
def create_employee(employee: EmployeeCreate,db:Session = Depends(get_db)):
    return crud_employee.create_employee(db,employee)

@router.put("/{emp_id}",response_model=Employee)
def update_employee(emp_id:str, employee:EmployeeCreate, db:Session = Depends(get_db)):
    return crud_employee.update_employee(db,emp_id,employee)

@router.delete("/{emp_id}")
def delete_employee(emp_id:str, db:Session = Depends(get_db)):
    return crud_employee.delete_employee(db,emp_id)

@router.post("/login")
def login(req: LoginRequest, db:Session = Depends(get_db)):
    result = crud_employee.authenticate_employee(req.emp_fname,req.password,db)

    if not result:
        raise HTTPException(status_code=401,detail="Invailid username or password")
    
    employee,dept_name = result
    return { 
        "emp_id": employee.emp_id,
        "emp_fname": employee.emp_fname,
        "emp_lname": employee.emp_lname,
        "dept_name": dept_name
    }