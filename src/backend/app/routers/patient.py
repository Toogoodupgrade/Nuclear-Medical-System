from fastapi import Depends,APIRouter,HTTPException
from database import get_db
from sqlalchemy.orm import Session
from schemas.patient import Patient,PatientCreate,PatientSearch
from crud import patient as crud_patient

router = APIRouter(prefix="/patients",tags=["Patients"])

@router.get("/",response_model=list[Patient])
def get_patients(db=Depends(get_db)):
    return crud_patient.get_patients(db)

@router.post("/",response_model=Patient)
def create_patient(patient: PatientCreate,db:Session = Depends(get_db)):
    return crud_patient.create_patient(db,patient)

@router.put("/{hn}",response_model=Patient)
def update_patient(hn:str, patient:PatientCreate, db:Session = Depends(get_db)):
    updated = crud_patient.update_patient(db,hn,patient)
    if not updated:
        raise HTTPException(status_code=404,detail="Patient Not found")
    return updated

@router.delete("/{hn}")
def delete_patient(hn:str, db:Session = Depends(get_db)):
    deleted = crud_patient.delete_patient(db,hn)
    if not deleted:
        raise HTTPException(status_code=404,detail="Patient not found")
    return {"message": "Patient deleted"}

@router.get("/search", response_model=list[PatientSearch])
def search_patients_api(
    q: str,
    db: Session = Depends(get_db)
):
    return crud_patient.search_patients(db, q)

@router.get("/{hn}",response_model=Patient)
def get_selected_patient(hn:str,db:Session = Depends(get_db)):
    patient = crud_patient.get_patient_by_hn(db,hn)
    if not patient:
        raise HTTPException(status_code=404,detail="Patient not found")
    return patient