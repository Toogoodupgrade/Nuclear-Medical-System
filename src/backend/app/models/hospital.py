from database import Base
from sqlalchemy import String,Column

class HospitalDB(Base):
    __tablename__ = "hospital"
    hospital_id = Column(String(10),primary_key=True)
    hospital_name = Column(String(100),nullable=False)