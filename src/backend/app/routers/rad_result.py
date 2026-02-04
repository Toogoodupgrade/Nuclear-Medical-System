from fastapi import APIRouter,Depends
from sqlalchemy.orm import Session
from database import get_db
from crud import rad_result as crud_rad_result
from schemas.rad_result import RadResultCreate,RadResultDetail,RadResultDataGrid,RadResultUpdate

router = APIRouter(prefix="/rad_results",tags=["Rad_Results"])

@router.get("/", response_model=list[RadResultDataGrid])
def get_rad_results(hn: str, db: Session = Depends(get_db)):
    return crud_rad_result.get_rad_result_by_hn(hn, db)

@router.get("/{rad_res_id}", response_model=RadResultDetail)
def get_rad_result_detail(rad_res_id: str, db: Session = Depends(get_db)):
    return crud_rad_result.get_rad_result_detail(rad_res_id, db)

# @router.post("/", response_model=RadResultDetail)
# def create_rad_result(req: RadResultCreate,emp_id: str = Depends(crud_rad_result.get_current_emp_id),db: Session = Depends(get_db)):
#     return crud_rad_result.create_rad_result(req, emp_id,db)

@router.put("/{rad_res_id}", response_model=RadResultDetail)
def update_rad_result(rad_res_id: str, req: RadResultUpdate, db: Session = Depends(get_db)):
    return crud_rad_result.update_rad_result(rad_res_id, req,db)