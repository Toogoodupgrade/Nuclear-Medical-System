from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey
from sqlalchemy.orm import relationship

class Rad_MachineDB(Base):
    __tablename__ = "rad_machine"
    rad_machine_id = Column(String(10),primary_key=True)
    machine_name = Column(String(50),nullable=False)

    tests = relationship("Rad_TestDB",back_populates="machine")