from database import Base
from sqlalchemy import String,Column,ForeignKey
from sqlalchemy.orm import relationship

class Lab_TestDB(Base):
    __tablename__ = "lab_test"
    lab_test_id = Column(String(10),primary_key=True)
    lab_test_name = Column(String(50),nullable=False)
    lab_test_category = Column(String(50),nullable=True)
    dept_id = Column(String(10),ForeignKey("department.dept_id"),nullable=True)
    method = Column(String(50),nullable=True)
    container = Column(String(50),nullable=True)
    volume = Column(String(50),nullable=True)

    lab_detail = relationship("Lab_ReqDetailDB",back_populates="lab_tests",cascade="all, delete-orphan")