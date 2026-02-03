from database import Base
from sqlalchemy import String,Column,ForeignKey
from sqlalchemy.orm import relationship


class Lab_TestParamDB(Base):
    __tablename__ = "lab_test_parameter"
    param_id = Column(String(10),primary_key=True)
    # lab_test_id = Column(String(10),nullable=False,ForeignKey("lab_test.lab_test_id"))
    lab_param_name = Column(String(50),nullable=True)
    lab_param_code = Column(String(50),nullable=True)
    lab_unit = Column(String(50),nullable=True)
    lab_normal_min = Column(String(50),nullable=True)
    lab_normal_max = Column(String(50),nullable=True)
    lab_normal_test = Column(String(50),nullable=False)


    # lab_test = relationship("labDB")