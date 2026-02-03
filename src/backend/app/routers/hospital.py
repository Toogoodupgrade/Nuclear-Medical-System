from fastapi import Depends,APIRouter
from database import get_db
from sqlalchemy.orm import Session
from schemas.hospital import HospitalRead
from crud import hospital as crud_hospital

router = APIRouter(prefix="/hospitals",tags=["Hospitals"])

@router.get("/",response_model=list[HospitalRead])
def get_hospitals(db=Depends(get_db)):
    return crud_hospital.get_hospitals(db)
