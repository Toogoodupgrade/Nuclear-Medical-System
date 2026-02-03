from database import Base
from sqlalchemy import String,Column,ForeignKey
from sqlalchemy.orm import relationship

class Rad_ReqDetailDB(Base):
    __tablename__ = "rad_req_detail"
    rad_detail_id = Column(String(10),primary_key=True)
    rad_req_id = Column(String(10),ForeignKey("rad_req.rad_req_id"),nullable=False)
    rad_test_id = Column(String(10),ForeignKey("rad_test.rad_test_id"),nullable=False)
    precaution = Column(String(255),nullable=True)
    otherpart = Column(String(255),nullable=True)

    request = relationship("Rad_ReqDB",back_populates="details")
    # test = relationship("Rad_TestDB")