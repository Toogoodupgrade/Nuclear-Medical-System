from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
from sqlalchemy.orm import relationship

class PatientDB(Base):
    __tablename__ = "patient"
    hn = Column(String(10),primary_key=True)
    pt_fname = Column(String(50),nullable=False)
    pt_lname = Column(String(50),nullable=False)
    pt_tel = Column(String(50),nullable=True)
    pt_gender = Column(String(50),nullable=False)
    pt_dob = Column(DateTime,nullable=False)
    pt_level = Column(String(50),nullable=True)
    pt_medical_condition = Column(String(255),nullable=True)
    pt_affiliation = Column(String(50),nullable=False)
    right_id = Column(String(10),ForeignKey("patient_right.right_id"),nullable=False)
