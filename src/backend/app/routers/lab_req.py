from fastapi import Depends,APIRouter
from database import get_db
from sqlalchemy.orm import Session
from schemas.lab_req import Lab_Req,Lab_ReqCreate
from crud import lab_req as curd_lab_req

router = APIRouter(prefix="/lab_reqs",tags=["Lab_reqs"])

@router.get("/",response_model=list[Lab_Req])
def get_lab_reqs(db=Depends(get_db)):
    return curd_lab_req.get_lab_reqs(db)

@router.post("/",response_model=Lab_Req)
def create_lab_req(req: Lab_ReqCreate,db:Session = Depends(get_db)):
    return curd_lab_req.create_lab_req(req,db)

@router.put("/{lab_req_id}",response_model=Lab_Req)
def update_lab_req(lab_req_id:str, lab_req:Lab_ReqCreate, db:Session = Depends(get_db)):
    return curd_lab_req.update_lab_req(db,lab_req_id,lab_req)

@router.delete("/{lab_req_id}")
def delete_lab_req(lab_req_id:str, db:Session = Depends(get_db)):
    return curd_lab_req.delete_lab_req(db,lab_req_id)
