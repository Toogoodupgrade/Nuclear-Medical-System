from fastapi import APIRouter,Depends
from sqlalchemy.orm import Session
from database import get_db
from crud import lab_result as crud_lab_result
from schemas.lab_result import LabResultDataGrid, LabResultDetail

router = APIRouter(prefix="/lab_results",tags=["Lab_Results"])

@router.get("/", response_model=list[LabResultDataGrid])
def get_lab_results(hn: str, db: Session = Depends(get_db)):
    return crud_lab_result.get_lab_result_by_hn(hn, db)

@router.get("/{lab_res_id}", response_model=LabResultDetail)
def get_lab_result_detail(lab_res_id: str, db: Session = Depends(get_db)):
    return crud_lab_result.get_lab_result_detail(lab_res_id, db)
