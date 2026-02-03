from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
from sqlalchemy.orm import relationship

class Rad_ReqDB(Base):
    __tablename__ = "rad_req"
    rad_req_id = Column(String(10),primary_key=True)
    hn = Column(String(10),nullable=False)
    emp_id = Column(String(10),nullable=False)
    rad_req_date = Column(DateTime,nullable=True)
    rad_req_impression = Column(String(255),nullable=True)
    rad_req_history = Column(String(255),nullable=True)
    rad_req_urgency_level = Column(String(50),nullable=True)
    rad_req_status = Column(String(50),nullable=True,default="pending")

    details = relationship("Rad_ReqDetailDB",back_populates="request",
                           cascade="all, delete-orphan")