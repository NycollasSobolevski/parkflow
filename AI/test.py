from ultralytics import YOLO

model = YOLO("./runs/detect/train3/weights/last.pt")

result = model.predict(source="./test2.jpg", conf=0.25, iou=0.45, save=True, save_txt=True, save_conf=True)
print(result)
# result = model.predict(source="./test01.jpg", conf=0.25, iou=0.45, save=True, save_txt=True, save_conf=True)