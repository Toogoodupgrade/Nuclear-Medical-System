from pydantic import BaseModel

class Lab_ReqDetailCreate(BaseModel):
    lab_test_id: str
    examtp: str | None = None
    other: str | None = None