#include <LiquidCrystal.h>
LiquidCrystal lcd(8,9,4,5,6,7);

#include <Wire.h> 
#include <Adafruit_BMP085.h>
#include <Stepper.h>
Adafruit_BMP085 bmp;

long          V = 0;           // The tich   
float         T = 0;           // Nhiet do
float         P = 0;           // Ap suat

const long    Vmax = 91745;    // The tich lon nhat
const long    Vmin = 84356;    // The tich nho nhat   8 vong                               

const float   P_delta = 0.05;  // Nguong ap suat cho phep chenh lech trong thi nghiem 3

const int     SPEED = 200;     // toc do cua step motor
const int     STEP = 64;       // so buoc step motor
const int     SO_BUOC_CHUAN = 2048;  // Tuy chinh so buoc quay cua step motor trong moi function
const int     MOT_VONG      = 2048;  // 1 vong step motor
long          buoc_hien_tai = 0;
Stepper       stepper( STEP,2,11,3,12);

boolean       xuoi_chieu = true;   // Huong chay cua pitong
                               //   true:  pitong chay vao, V giam
                               //   false: pitong chay ra, V tang

int           TN_da_chon  =0;  // Thi nghiem dang chon 
boolean       flag        = false;
int           lcd_key     = 0;
int           adc_key_in  = 0;

#define       btnSELECT     1
#define       btnLEFT       2
#define       btnRIGHT      3
#define       btnUP         4
#define       btnDOWN       5
#define       btnNONE       0

int           thoi_gian_0  = 0;    // Thoi gian luc bat dau tinh gio           
const long    THOI_GIAN_TN = 60000*10; // Thoi gian toi da chay mot thi nghiem (10 phut) 


// ********************   CHUONG TRINH  ***************************

void setup(){
    stepper.setSpeed(SPEED);  
    Serial.begin(9600);
    lcd.begin(16,2); 
    if(!bmp.begin()){
        hien_thi("XEM LAI DAY CAM!",0,0,true);
        while(1);
    }
    gioi_thieu();
    V = Vmax;
    TN_da_chon = 0;
    buoc_hien_tai = 0;
    hien_thi_lua_chon_TN();
    randomSeed(analogRead(1));
}
void loop(){      
      int nut_bam = lay_nut_bam();
      if(nut_bam != 0 && nut_bam != TN_da_chon){                    
            if( nut_bam == 2 || nut_bam == 3 || nut_bam == 4 || nut_bam == 5){
                flag = true; 
                TN_da_chon = nut_bam;
                ten_thi_nghiem();
            }
            else if(nut_bam == 1){
                if(flag == true && ( TN_da_chon == 2 || TN_da_chon == 3 || TN_da_chon == 4 || TN_da_chon == 5)){
                  chay_thi_nghiem();
                  TN_da_chon = 0;
                }
                else{
                  flag = false;
                  hien_thi_lua_chon_TN();
                }
            }       
      }      
}

// ********************  4 THI NGHIEM   *******************

void gioi_thieu(){
    hien_thi("CHUYEN NGANH",2,0,true);
    delay(1500);
    hien_thi("LLDH-PPGD VAT LI",0,1);
    delay(1500);
    hien_thi("GIANG VIEN - TS:",0,0,true);
    delay(1500);
    
    hien_thi("NGUYEN ANH THUAN",0,0,true);
    hien_thi("TUONG DUY HAI",1,1);
    delay(1500);

    hien_thi("HOC VIEN:",3,0,true);
    delay(1500);
    hien_thi("TRAN LE TRANG",1,1);
    delay(1500);
    
    hien_thi("CAC D/L CHAT KHI",0,0,true);
    delay(1500);
    hien_thi("VAT LI LOP 10",1,1);
    delay(1500);
    
    lcd.clear();
    //dem_nguoc(); 
    hien_thi("BAM NUT DE",3,0,true);
    hien_thi("CHON THI NGHIEM",1,1);
    delay(1000);
}

void thi_nghiem_dang_nhiet(){     
    lcd.clear();
    lcd.setCursor(1,0);
    lcd.print("TN: DANG NHIET");
    Serial.println("#(TN: DANG NHIET)");
    chuan_bi_TN();
    xuoi_chieu = true;
    HienThiCamBien();
    delay(2000);
    while (V > Vmin){      
      chay_motor();  
      HienThiCamBien();    
      delay(2000);
    }   
    xuoi_chieu = false;    
    hien_thi("Hoan thanh!",3,0,true);
    delay(3000);
}

void thi_nghiem_dang_tich(){ 
    thoi_gian_0 = millis(); 
    Serial.println("#(TN: DANG TICH)");
    lcd.clear();
    lcd.setCursor(1,0);
    lcd.print("TN: DANG TICH");
    chuan_bi_TN();
    lcd.clear();
    HienThiCamBien();
    delay(2000);
    while(het_thoi_gian_TN(THOI_GIAN_TN) == false){
        HienThiCamBien();
        delay(2000);
    }
    
    hien_thi("Hoan thanh!",3,0,true);
    delay(3000);
}

void thi_nghiem_dang_ap(){
    thoi_gian_0 = millis();
    Serial.println("#(TN: DANG AP)");
    lcd.clear();
    lcd.setCursor(2,0);
    lcd.print("TN: DANG AP");
    chuan_bi_TN();
    
    float P0 = (float)(bmp.readPressure()/1000);
    hien_thi("P0 = ",0,1); hien_thi_so(P0,5,1,false,2);hien_thi("kPa",11,1);
    delay(5000);
    HienThiCamBien();
    delay(2000);
    while (Vmin < V < Vmax){
        if (P > P0 + P_delta){
            xuoi_chieu = false;    
            chay_motor_buoc_nho(128); //MOT_VONG/16
        }
        else if (P < P0 - P_delta){
            xuoi_chieu = true;
            chay_motor_buoc_nho(128); //MOT_VONG/16 
        }   
        HienThiCamBien();
        delay(2000);
    }
    hien_thi("Hoan thanh!",3,0,true);
    delay(3000);
}

void thi_nghiem_ca_3_thay_doi(){ 
    thoi_gian_0 = millis();  
    Serial.println("#(TN: CA 3 BIEN DOI)");
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("TN: CA 3 B/DOI");
    xuoi_chieu = true; 
    HienThiCamBien();
    float t0 = T;
    int K = MOT_VONG; //quay 1 vong khi tang 0.5 oC 
    while(het_thoi_gian_TN(THOI_GIAN_TN) == false){
        while (Vmin < V < Vmax){       
            HienThiCamBien();
            delay(2000);  
            while(T < t0 + 0.5){  
                HienThiCamBien();
                delay(3000); 
                if(K > 0){               
                    chay_motor_buoc_nho(MOT_VONG/8); 
                    K -= MOT_VONG/8;
                }
            }
            t0 = t0 + 0.5; 
            K = MOT_VONG;          
        }
        xuoi_chieu = !xuoi_chieu;      
    }
    hien_thi("Hoan thanh!",3,0,true);
    delay(3000);
}




// ********************   HAM DUNG CHUNG   *****************************
void hien_thi_lua_chon_TN(){
        hien_thi("LEFT: DANG NHIET",0,0,true);
        hien_thi("RIGHT: DANG TICH",0,1);
        delay(3000);
        hien_thi("UP:   DANG AP",0,0,true);
        hien_thi("DOWN: CA 3 B/DOI",0,1);
}
int lay_nut_bam(){
    adc_key_in = analogRead(0);
    if (adc_key_in < 50)   return btnRIGHT;  
    if (adc_key_in < 250)  return btnUP; 
    if (adc_key_in < 400)  return btnDOWN; 
    if (adc_key_in < 600)  return btnLEFT; 
    if (adc_key_in < 850)  return btnSELECT; 
    return btnNONE;
}
void ten_thi_nghiem(){
    switch(TN_da_chon){
        case 2:
            hien_thi("DANG NHIET",3,0,true);
            break;
        case 3:
            hien_thi("DANG TICH",3,0,true);
            break;
        case 4:
            hien_thi("DANG AP",4,0,true);
            break;
        case 5:
            hien_thi("CA 3 THAY DOI",1,0,true);
            break;
    }
}
void chay_thi_nghiem(){   
    switch (TN_da_chon){
        case 2:
            thi_nghiem_dang_nhiet();
            break;
        case 3:
            thi_nghiem_dang_tich();
            break;
        case 4:
            thi_nghiem_dang_ap();
            break;
        case 5:
            thi_nghiem_ca_3_thay_doi();
            break;         
        default: 
            break;
    }  
}
void HienThiCamBien(){    
    T = (float)(bmp.readTemperature());
    V = tinh_V();
    P = ((float)(bmp.readPressure())/1000);
    
     // in ra Serial
     Serial.println("{");
     Serial.print("t: "); Serial.print(T,2);Serial.println(" oC;");
     Serial.print("p: "); Serial.print(P,2);Serial.println(" kPa;");
     Serial.print("v: "); Serial.print(V);Serial.println(" mm3;");
     Serial.print("millis: "); Serial.print(millis());Serial.println(";");
     Serial.println("}");
     
     // in ra LCD
     lcd.clear();
     lcd.setCursor(0,0);
     lcd.print(T,2);
     lcd.setCursor(6,0);
     lcd.print("oC");
     
     lcd.setCursor(11,0);
     lcd.print(V);
     lcd.setCursor(13,1);
     lcd.print("mm3");
     
     lcd.setCursor(0,1);
     lcd.print(P,2);
     lcd.setCursor(7,1);
     lcd.print("kPa");    
    
}

long tinh_V(){
    return Vmax - round((float)(PI*sq(14)*1.5*buoc_hien_tai/MOT_VONG));
}

void chuan_bi_TN(){
    hien_thi("DANG CHUAN BI...",0,1);    
    delay(2000);
    hien_thi("                ",0,1);
    
    if(TN_da_chon == 2){ //dang nhiet
       
    }
    else if (TN_da_chon == 3){ //dang tich
        int n = random(1,6);
        chay_motor_den_vi_tri(Vmax - (long)(n*PI*sq(14)*1.5));// < Vmax n vong.
    }
    else if (TN_da_chon == 4){  
      int n = random(4,8);
      chay_motor_den_vi_tri(Vmax - (long)(n*PI*sq(14)*1.5));// < Vmax n vong.
    }
    else if (TN_da_chon == 5){    }  
    V = tinh_V();  
    dem_nguoc();
    lcd.clear();
}

boolean het_thoi_gian_TN(long _time){
    if ((millis() - thoi_gian_0) > _time){
        return true;
    }
    else
        return false;
}

void dem_nguoc(){
    hien_thi("                ",0,1);
    int dem_nguoc = 3;
    while (dem_nguoc > 0){
        hien_thi_so(dem_nguoc,7,1,false,0);
        dem_nguoc --;
        delay(1000);    
    }
}


void hien_thi(String text, int x, int y){
    Serial.println(text);
    lcd.setCursor(x,y);
    lcd.print(text);
}
void hien_thi(String text, int x, int y, boolean clear){
    Serial.println(text);
    if(clear == true){ lcd.clear();}
    lcd.setCursor(x,y);
    lcd.print(text);
}
void hien_thi_so(float number, int x, int y, boolean clear,int n){
    Serial.println(number,n);
    if(clear == true){ lcd.clear();}
    lcd.setCursor(x,y);
    lcd.print(number,n);
}


// Chay step motor "SO_BUOC_CHUAN" buoc 
void chay_motor(){
    if(xuoi_chieu == true){
        if (V > Vmin){ 
            stepper.step(SO_BUOC_CHUAN);
            buoc_hien_tai = buoc_hien_tai + SO_BUOC_CHUAN;
        }
    }
    else{
        if (V < Vmax){
            stepper.step(-SO_BUOC_CHUAN);
            buoc_hien_tai = buoc_hien_tai - SO_BUOC_CHUAN;
        }
    }    
    V = tinh_V();
}
// Chay step motor theo (_buoc) 
void chay_motor_buoc_nho(int _buoc){
    if(xuoi_chieu == true){
        if (V > Vmin){ 
            stepper.step(_buoc);
            buoc_hien_tai = buoc_hien_tai + _buoc;
        }
    }
    else{
        if (V < Vmax){
            stepper.step(-_buoc);
            buoc_hien_tai = buoc_hien_tai - _buoc;
        }
    }
    V = tinh_V();
}
// Chay step motor den vi tri (vi_tri)
void chay_motor_den_vi_tri(long vi_tri){
    if(V > vi_tri){
        xuoi_chieu = true;
        while (V > vi_tri){ 
            buoc_hien_tai = buoc_hien_tai + SO_BUOC_CHUAN;       
            stepper.step(SO_BUOC_CHUAN);  
            V = tinh_V();          
        }
    }
    else if (V < vi_tri){
        xuoi_chieu = false;
        while (V < vi_tri){ 
            buoc_hien_tai = buoc_hien_tai - SO_BUOC_CHUAN;       
            stepper.step(-SO_BUOC_CHUAN);
            V = tinh_V();
        }
    }
}
