from models.patient import PatientDB
from schemas.patient import PatientCreate
from sqlalchemy.orm import Session
from models.patient_right import PatientRightDB
from sqlalchemy import or_

def get_patients(db: Session):
    patients = (
        db.query(PatientDB,PatientRightDB.right_name)
        .join(PatientRightDB,PatientDB.right_id == PatientRightDB.right_id)
        .all()
    )
    result = []
    for patient,pt_right_name in patients:
        result.append({
            "hn": patient.hn,
            "pt_fname": patient.pt_fname,
            "pt_lname": patient.pt_lname,
            "pt_tel": patient.pt_tel,
            "pt_gender": patient.pt_gender,
            "pt_dob": patient.pt_dob,
            "pt_level":patient.pt_level,
            "pt_medical_condition": patient.pt_medical_condition,
            "pt_affiliation": patient.pt_affiliation,
            "right_name": pt_right_name,
        })
    return result

def create_patient(patient: PatientCreate,db:Session):
    db_patient = PatientDB(**patient.dict())
    db.add(db_patient)
    db.commit()
    db.refresh(db_patient)
    return db_patient

def update_patient(hn:str, patient:PatientCreate, db:Session):
    db_patient = db.query(PatientDB).filter(PatientDB.hn == hn).first()
    if not db_patient:
        return None
    for key,value in patient.dict().items():
        setattr(db_patient,key,value)
    db.commit()
    db.refresh(db_patient)
    return db_patient

def delete_patient(hn:str,db:Session):
    db_patient = db.query(PatientDB).filter(PatientDB.hn == hn).first()
    if not db_patient:
        return None
    db.delete(db_patient)
    db.commit()
    return True

def get_patient_by_hn(db: Session, hn: str):
    result = (
        db.query(PatientDB, PatientRightDB.right_name)
        .outerjoin(
            PatientRightDB,
            PatientDB.right_id == PatientRightDB.right_id
        )
        .filter(PatientDB.hn == hn)
        .first()
    )

    if not result:
        return None

    patient, right_name = result

    return {
        "hn": patient.hn,
        "pt_fname": patient.pt_fname,
        "pt_lname": patient.pt_lname,
        "pt_tel": patient.pt_tel,
        "pt_gender": patient.pt_gender,
        "pt_dob": patient.pt_dob,
        "pt_level": patient.pt_level,
        "pt_medical_condition": patient.pt_medical_condition,
        "pt_affiliation": patient.pt_affiliation,
        "right_name": right_name,
    }


def search_patients(db: Session, keyword: str, limit: int = 10):
    return (
        db.query(PatientDB)
        .filter(
            or_(
                PatientDB.hn.ilike(f"%{keyword}%"),
                PatientDB.pt_fname.ilike(f"%{keyword}%"),
                PatientDB.pt_lname.ilike(f"%{keyword}%"),
            )
        )
        .limit(limit)
        .all()
    )