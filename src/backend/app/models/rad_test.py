from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
from sqlalchemy.orm import relationship
from models.rad_machine import Rad_MachineDB

class Rad_TestDB(Base):
    __tablename__ = "rad_test"
    rad_test_id = Column(String(10),primary_key=True)
    test_name = Column(String(50),nullable=False)
    rad_machine_id = Column(String(10),ForeignKey("rad_machine.rad_machine_id"),nullable=False)

    machine = relationship(Rad_MachineDB,back_populates="tests")