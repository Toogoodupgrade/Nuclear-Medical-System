from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
from sqlalchemy.orm import relationship

class Lab_ReqDB(Base):
    __tablename__ = "lab_req"
    lab_req_id = Column(String(10),primary_key=True)
    emp_id = Column(String(10),ForeignKey("employee.emp_id"),nullable=False)
    hn = Column(String(10),ForeignKey("patient.hn"),nullable=False)
    lab_req_date = Column(DateTime,nullable=False)
    lab_req_status = Column(String(50),nullable=False)
    
    details = relationship("Lab_ReqDetailDB",back_populates="lab_request",
                           cascade="all, delete-orphan")
    req_ext = relationship("Req_ExtDB",back_populates="lab_request",cascade="all, delete-orphan")