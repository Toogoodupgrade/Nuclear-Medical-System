from database import Base
from sqlalchemy import String,Column,ForeignKey
from sqlalchemy.orm import relationship

class Lab_ReqDetailDB(Base):
    __tablename__ = "lab_req_detail"
    lab_detail_id = Column(String(10),primary_key=True)
    lab_req_id = Column(String(10),ForeignKey("lab_req.lab_req_id"),nullable=False)
    lab_test_id = Column(String(10),ForeignKey("lab_test.lab_test_id"),nullable=False)
    examtp = Column(String(50),nullable=True)
    other = Column(String(255),nullable=True)
    
    lab_request = relationship("Lab_ReqDB",back_populates="details")
    lab_tests = relationship("Lab_TestDB",back_populates="lab_detail")