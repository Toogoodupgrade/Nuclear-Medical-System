from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
# from sqlalchemy.orm import relationship

class Rad_ResultDB(Base):
    __tablename__ = "rad_result"
    rad_res_id = Column(String(10),primary_key=True)
    rad_req_id = Column(String(10),ForeignKey("rad_request.rad_req_id"),nullable=False)
    emp_id = Column(String(10),ForeignKey("employee.emp_id"),nullable=False)
    rad_machine_id = Column(String(10),ForeignKey("rad_machine.rad_machine_id"),nullable=False)
    rad_res_date = Column(DateTime,nullable=False)
    rad_res_findings_text = Column(String(255),nullable=True)
    rad_res_impression = Column(String(255),nullable=True)
    rad_res_image = Column(String(255),nullable=True)
    rad_res_status = Column(String(50),nullable=True)
