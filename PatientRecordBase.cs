[JsonPolymorphic(TypeDiscriminatorPropertyName = "recordType")]
[JsonDerivedType(typeof(ECGRecord), typeDiscriminator: "ECG")]
[JsonDerivedType(typeof(EchoCardiogramRecord), typeDiscriminator: "EchoCardiogram")]
[JsonDerivedType(typeof(CardiacEventRecord), typeDiscriminator: "CardiacEvent")]
[JsonDerivedType(typeof(ConsultationRecord), typeDiscriminator: "Consultation")]
public abstract class PatientRecordBase;
