from ultralytics import YOLO
import cv2
import easyocr
model = YOLO("./runs/detect/train3/weights/last.pt")

result = model.predict(source="./test4.jpeg", conf=0.25, iou=0.45)
print(result[0])

image_with_boxes = result[0].plot()
boxes = result[0].boxes
print("plate")

image_with_boxes = cv2.resize(image_with_boxes, (640, 640))  # Resize to 640x640
cv2.imshow("Image with Boxes", image_with_boxes)
if boxes is not None and len(boxes) > 0:
    for i, box in enumerate(boxes):
        # Coordenadas da caixa (x1, y1, x2, y2)
        x1, y1, x2, y2 = map(int, box.xyxy[0])  # box.xyxy é um tensor: (x1, y1, x2, y2)

        # Recorta a zona da placa na imagem
        placa_crop = cv2.imread("./test4.jpeg")[y1:y2, x1:x2]
        placa_crop = cv2.cvtColor(placa_crop, cv2.COLOR_BGR2GRAY)
        # Mostra o recorte da placa
        reader = easyocr.Reader(['pt'])
        result = reader.readtext(placa_crop)
        for k in result:
            print("\n")
            print(k)
        result = result[len(result) - 1][-2]
        font= cv2.FONT_HERSHEY_SIMPLEX
        res = cv2.putText(placa_crop, result, (10, 30), font, 1, (255, 255, 0), 2, cv2.LINE_AA)
        res = cv2.putText(placa_crop, "NVC0O", (10, 60), font, 1, (255, 255, 0), 2, cv2.LINE_AA)
        cv2.imshow(f"Placa {i+1}", placa_crop)

    cv2.waitKey(0)
    cv2.destroyAllWindows()
else:
    print("Nenhuma placa detectada.")

cv2.waitKey(0)
cv2.destroyAllWindows()
# result = model.predict(source="./test01.jpg", conf=0.25, iou=0.45, save=True, save_txt=True, save_conf=True)