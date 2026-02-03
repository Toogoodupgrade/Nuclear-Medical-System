from database import Base
from sqlalchemy import String,Column,DateTime,ForeignKey

class EmployeeDB(Base):
    __tablename__ = "employee"
    emp_id = Column(String(10),primary_key=True)
    emp_fname = Column(String(50),nullable=False)
    emp_lname = Column(String(50),nullable=False)
    emp_tel = Column(String(50),nullable=True)
    position_id = Column(String(10),nullable= False)
    dept_id = Column(String(10),ForeignKey("department.dept_id"),nullable=False)
    password = Column(String(50),nullable=False)