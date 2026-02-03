from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
# from sqlalchemy.orm import relationship

class Lab_ResDetailDB(Base):
    __tablename__ = "lab_res_detail"
    lab_res_detail_id = Column(String(10),primary_key=True)
    lab_res_id = Column(String(10),nullable=False)
    param_id = Column(String(10),nullable=False)
    lab_detail_result_value = Column(String(50),nullable=True)
    lab_detail_result_flag = Column(String(50),nullable=True)

    # right = relationship("PatientRightDB")