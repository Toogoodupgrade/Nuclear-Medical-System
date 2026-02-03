# from database import Base
# from sqlalchemy import String,Column,DateTime,ForeignKey

# class QueueDb(Base):
#     __tablename__ = "queue"
#     queue_id = Column(String(10), primary_key=True)
#     hn = Column(String(10), ForeignKey("patient.hn"), nullable=False)
#     queue_date = Column(DateTime, nullable=False)
#     queue_status = Column(String(50), nullable=False)