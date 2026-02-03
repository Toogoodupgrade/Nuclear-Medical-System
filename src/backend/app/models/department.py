from database import Base
from sqlalchemy import String,Column,DateTime

class DepartmentDB(Base):
    __tablename__ = "department"
    dept_id = Column(String(10),primary_key=True)
    dept_name = Column(String(50),nullable=False)