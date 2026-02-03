from database import Base
from sqlalchemy import String,Column,DateTime

class Lab_ResultDB(Base):
    __tablename__ = "lab_result"
    lab_res_id = Column(String(10),primary_key=True)
    lab_req_id = Column(String(10),nullable=False)
    emp_id = Column(String(10),nullable=False)
    lab_res_date = Column(DateTime,nullable=False)
    lab_res_diagnosis = Column(String(50),nullable=True)
    lab_res_status = Column(String(50),nullable=True)
    lab_res_summary = Column(String(255),nullable=True)