from ultralytics import YOLO

model = YOLO("yolo11n.pt") 
model.train(data="./data.yaml", epochs=100, batch=16, imgsz=400)

model_name = "LicensePlateTreined_yolov11n"
model.save(f"./{model_name}.pt")

model = YOLO("./"+model_name + ".pt")
model.export(format="tflite")
tflite_model = YOLO(model_name + ".tflite")

result = tflite_model("./test01.jpg")