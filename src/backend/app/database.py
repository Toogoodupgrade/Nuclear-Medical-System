from sqlalchemy import create_engine
from sqlalchemy.orm import sessionmaker
from sqlalchemy.ext.declarative import declarative_base

Db_Con = ("mssql+pyodbc://MyPC/NuclearMedicalDepartmentDB"
          "?trusted_connection=yes"
          "&driver=ODBC+Driver+17+for+SQL+Server")
engine = create_engine(Db_Con,pool_pre_ping=True)
SessionLocal = sessionmaker(autoflush=False,autocommit=False,bind=engine)
Base = declarative_base()

def get_db():
    db = SessionLocal()
    try:
        yield db
    finally:
        db.close()