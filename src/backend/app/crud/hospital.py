from models.hospital import HospitalDB
from sqlalchemy.orm import Session
from models.patient_right import PatientRightDB

def get_hospitals(db: Session):
    return db.query(HospitalDB).all()
