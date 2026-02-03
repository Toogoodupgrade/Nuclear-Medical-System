from fastapi import Depends,APIRouter
from database import get_db
from sqlalchemy.orm import Session
from schemas.rad_req import Rad_Req,Rad_ReqCreate
from crud import rad_req as crud_rad_req

router = APIRouter(prefix="/rad_reqs",tags=["Rad_Reqs"])

@router.get("/",response_model=list[Rad_Req])
def get_rad_reqs(db=Depends(get_db)):
    return crud_rad_req.get_rad_reqs(db)

@router.post("/",response_model=Rad_Req)
def create_rad_reqs(
    req: Rad_ReqCreate,
    db: Session = Depends(get_db)
):
    return crud_rad_req.create_rad_req(db, req)

@router.put("/{rad_req_id}",response_model=Rad_Req)
def update_rad_req(rad_req_id:str, rad_req:Rad_ReqCreate, db:Session = Depends(get_db)):
    return crud_rad_req.update_rad_req(db,rad_req_id,rad_req)

@router.delete("/{rad_req_id}")
def delete_rad_req(rad_req_id:str, db:Session = Depends(get_db)):
    return crud_rad_req.delete_rad_req(db,rad_req_id)
