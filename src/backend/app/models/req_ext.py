from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
from sqlalchemy.orm import relationship

class Req_ExtDB(Base):
    __tablename__ = "req_ext"
    request_external_id = Column(String(10),primary_key=True)
    lab_req_id = Column(String(10),ForeignKey("lab_req.lab_req_id"),nullable=False)
    hospital_id = Column(String(10),ForeignKey("hospital.hospital_id"),nullable=True)
    request_status = Column(String(50),nullable=True)
    receive_date = Column(DateTime,nullable=True)
    
    lab_request = relationship("Lab_ReqDB",back_populates="req_ext")