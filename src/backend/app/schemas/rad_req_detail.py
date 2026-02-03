
from pydantic import BaseModel


class Rad_ReqDetailCreate(BaseModel):
    rad_test_id: str
    precaution: str | None = None
    otherpart: str | None = None