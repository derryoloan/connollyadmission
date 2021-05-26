select Patient.PatientName,Patient_RiskFactors.RiskFactor,Patient_MedicalSurgicalHistory.MedicalSurgicalHistory,Patient_FamilyHistory.FamilyHistory
from Patient left outer join Patient_RiskFactors on patient.MRN=Patient_RiskFactors.MRN left outer join Patient_MedicalSurgicalHistory on Patient.MRN=Patient_MedicalSurgicalHistory.MRN
left outer join Patient_FamilyHistory on Patient.MRN=Patient_FamilyHistory.MRN
 where Patient.Mrn ='12345'