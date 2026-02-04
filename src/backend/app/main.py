from fastapi import FastAPI
from routers import patient,employee,lab_req,rad_req,hospital,req_ext,rad_result,lab_result
import models

app = FastAPI()
app.include_router(patient.router)
app.include_router(employee.router)
app.include_router(rad_req.router)
app.include_router(lab_req.router)
app.include_router(hospital.router)
app.include_router(req_ext.router)
app.include_router(rad_result.router)
app.include_router(lab_result.router)