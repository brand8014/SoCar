# 사용기술
### 언어
* C# 3.0+
* C++
### 프레임워크
* .NET FRAMEWORK 4.8
* WINFORM
### 데이터베이스
* MSSQL Server 2019

### 데이터베이스 스키마
![D B](Documents/DB.png)

* 코드성 테이블이 많아서 코드카테고리 테이블과 
코드 테이블을 만들었고 그 결과 불필요한 테이블을 최소화했다.

* Car 테이블과 Insurance 테이블이 다:다 관계를 가진다.

* Visual Studio에서 테이블에 외래키만 가지고 있으면 
ADO.NET에 포함되지않아서 임의로 dummy속성을 테이블에 추가한다

# Point Of Interest
 ## Form의 삭제이벤트가 발생하지 않는 문제
### 증상
* 