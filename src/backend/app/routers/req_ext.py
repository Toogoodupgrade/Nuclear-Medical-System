from fastapi import Depends,APIRouter
from database import get_db
from sqlalchemy.orm import Session
from schemas.req_ext import Req_Ext,Req_ExtCreate,Req_ExtRead
from crud import req_ext as curd_req_ext

router = APIRouter(prefix="/req_exts",tags=["Req_Ext"]) 

@router.get("/",response_model=list[Req_Ext])
def get_req_exts(db=Depends(get_db)):
    return curd_req_ext.get_req_exts(db)

@router.post("/",response_model=Req_ExtRead)
def create_req_ext(req: Req_ExtCreate,db:Session = Depends(get_db)):
    return curd_req_ext.create_req_ext(req,db)

@router.put("/{req_ext_id}",response_model=Req_Ext)
def update_req_ext(req_ext_id:str, req_ext:Req_ExtCreate, db:Session = Depends(get_db)):
    return curd_req_ext.update_req_ext(db,req_ext_id,req_ext)

@router.delete("/{req_ext_id}")
def delete_req_ext(req_ext_id:str, db:Session = Depends(get_db)):
    return curd_req_ext.delete_req_ext(db,req_ext_id)
