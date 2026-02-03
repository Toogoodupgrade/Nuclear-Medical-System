from database import Base
from sqlalchemy import String,Column

class PatientRightDB(Base):
    __tablename__ = "patient_right"
    right_id = Column(String(10),primary_key=True)
    right_name = Column(String(50),nullable=False)