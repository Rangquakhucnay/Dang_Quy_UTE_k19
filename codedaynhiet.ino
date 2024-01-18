String makitu1;
int s_VG, s_TH;
int v_TH, t_TH;
float VG, TH, R_TH;
void setup() {
    Serial.begin(9600);  //Mở cổng Serial để giap tiếp | tham khảo Serial
    pinMode(13,OUTPUT);
  }
  
void loop() {
  s_VG = analogRead(A3);    //Lấy tín hiệu VG 
  s_TH = analogRead(A4);    //Lấy tín hiệu TH
  VG = map(s_VG,0,1023,0,5150)/1000.00;     //Chuyển tín hiệu VG thành đơn vị volt
  v_TH = map(s_TH,0,1023,0,5150);           //Chuyển tín hiệu TH thành đơn vị millivolt
  t_TH = map(v_TH,2570,210,20,90);          //Đổi điện áp TH sang nhiệt độ - các thông số dựa trên thực nghiệm
  TH = v_TH/1000.00;                        //Đổi tín hiệu TH đơn vị millivolt thành đơn vị volt
  R_TH = v_TH*2.00/(5150.00-v_TH);          //Tính toán giá trị điện trở của cảm biến


   // Xử lý relay và gửi giá trị
  if(Serial.available()) { // nếu có dữ liệu gửi đến
    String makitu = Serial.readStringUntil('\n'); // đọc giá trị gửi đến cho đến khi gặp kí tự xuống dòng \n
    makitu1 = makitu;
  if(makitu == "a") {digitalWrite(13,HIGH);} //Thực hành dây nhiệt
    else {digitalWrite(13,LOW);} 
  }


  if(makitu1 == "a") {
  Serial.println("VG" + String(VG) + "R_TH" + String(R_TH) + "tTH" + String(t_TH) + "PA" + String(TH)); 
  }


  delay(1);
}
