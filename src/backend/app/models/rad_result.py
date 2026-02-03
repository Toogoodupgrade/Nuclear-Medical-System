from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
# from sqlalchemy.orm import relationship

class Rad_ResultDB(Base):
    __tablename__ = "rad_result"
    rad_res_id = Column(String(10),primary_key=True)
    rad_req_id = Column(String(10),nullable=False)
    emp_id = Column(String(10),nullable=False)
    rad_machine_id = Column(String(10),nullable=False)
    rad_res_date = Column(DateTime,nullable=False)
    rad_res_finding_text = Column(String(255),nullable=True)
    rad_res_impression = Column(String(255),nullable=True)
    rad_res_image = Column(String(255),nullable=True)
    rad_res_status = Column(String(50),nullable=True)

    # right = relationship("PatientRightDB")