# 테스트 주도개발
<h3>Attribute</h3>
<ul>
<li>SetUp : 테스트를 위한 설정값 초기화(Microsoft.VisualStudio.TestTools.UnitTesting 에선 TestInitialize)</li>
<li>TearDown : 테스트를 위한 설정값 청소(Microsoft.VisualStudio.TestTools.UnitTesting 에선 TestCleanup)</li>
<li>TestFixture : 테스트 클래스(Microsoft.VisualStudio.TestTools.UnitTesting 에선 TestClass)</li>
<li>Test : 테스트 메소드(Microsoft.VisualStudio.TestTools.UnitTesting 에선 TestMethod)</li>
<li>ExpectedException : 제대로된 예외가 발생하는지 검사</li>
<li>Ignore : 테스트 무시</li>
<li>Category : 테스트의 카테고리 설정(Microsoft.VisualStudio.TestTools.UnitTesting 에선 TestCategory)</li>
</ul>
<h3>Class</h3>
Assert : 실제 객체나 값이 기대하는 것과 동일한지 검사하는 클래스
<h3>의존성을 분리하는 기법</h3>
<ul>
  <li>하부 구현을 교체할 수 있도록 인터페이스 추출</li>
  <li>테스트할 클래스에 스텁 구현 주입</li>
  <li>생성자 레벨에서 인터페이스 받기</li>
  <li>get 또는 set 프로퍼티에서 인터페이스 받기</li>
  <li>메서드 호출 바로 직전에 스텁 받기</li>
</ul>
생성자 주입에서는 해당 의존물이 필수적인 경우, 프로퍼티 주입은 해당 의존물이 선택적인 경우에 사용하는게 좋다.

<h3>스텁(Stub)</h3>
시스템 상의 외부 의존물을 대신하기 위해 쓰이는 제어 가능한 대체물이다. 스텁을 사용하면 의존관계를 직접 다루지 않고서도 코드를 테스트해 볼 수 있다.
<h3>목 객체(mock object)</h3>
시스템 내부에서 단위 테스트의 통과 또는 실패 여부를 판단하는 가짜 객체를 말한다. 목 객체는 가짜 객체를 이용해 테스트 대상 객체가 올바른 방식으로 상호작용했는지 검증한다. 대체로 테스트당 하나의 목 객체만 사용한다.
<h3>격리 프레임워크(isolation framework)</h3>
목과 스텁 객체를 훨씬 쉽게 생성할 수 있게 해주는 API들의 모음이다. 격리 프레임워크를 이용하면 개발자들이 객체의 상호작용을 테스트 하거나 시뮬레이션 하기위해 코드를 반복 작성하는 일을 줄일 수 있다.

<h3>상속에 기반을 둔 3가지 패턴</h3>
<ul>
<li>추상 테스트 인프라 클래스</li>
핵심적인 공통 인프라를 포함하는 추상 테스트 클래스를 만들고 다른 테스트 클래스를 파생시킨다.
<li>템플릿 테스트 클래스</li>
파생 클래스에서 구현해야 하는 메서드를 포함하는 추상 클래스를 만든다.
<li>추상 테스트 드라이버 클래스</li>
파생 클래스에서 상속은 받지만 다시 구현할 필요는 없는 테스트 메서드 구현을 담는 추상 테스트 클래스를 생성한다.
</ul>
<h2>참고</h2>
<h3>SOLID</h3>
<ol>
<li><a href ="http://ko.wikipedia.org/wiki/%EB%8B%A8%EC%9D%BC_%EC%B1%85%EC%9E%84_%EC%9B%90%EC%B9%99">단일 책임 원칙(SRP:Single Responsibility Principle)</a>:하나의 클래스는 하나의 책임을 가져야한다. 단 하나의 변경 이유만을 가져야한다.</li>
<li><a href="http://ko.wikipedia.org/wiki/%EA%B0%9C%EB%B0%A9-%ED%8F%90%EC%87%84_%EC%9B%90%EC%B9%99">개방 폐쇄 원칙:(OCP:Open-Closed Principle)</a>:하나에 모듈에 수정을 가할때 다른 모듈들도 모두 고치지 않도록 한다. 이를 위해서 확장에 대하여 열려있고, 수정에 대해서 닫혀있어야 한다. 추상화는 개방-폐쇄 원칙의 핵심 요소이다.</li>
<li><a href="http://ko.wikipedia.org/wiki/%EB%A6%AC%EC%8A%A4%EC%BD%94%ED%94%84_%EC%B9%98%ED%99%98_%EC%9B%90%EC%B9%99">리스코프 치환 원칙(LSP:Liskov substitution principle)</a>:부모 클래스로부터 파생된 자식 클래스의 객체는 수정없이 언제 어디서나 부모클래스 객체로 대체될 수 있어야 한다.</li>
<li><a href="http://ko.wikipedia.org/wiki/%EC%9D%B8%ED%84%B0%ED%8E%98%EC%9D%B4%EC%8A%A4_%EB%B6%84%EB%A6%AC_%EC%9B%90%EC%B9%99">인터페이스 분리 원칙(ISP:Interface Segregation Principle)</a>:클라이언트가 자신이 이용하지 않는 메서드에 의존하지 않아야 한다.</li>
<li><a href="http://ko.wikipedia.org/wiki/%EC%9D%98%EC%A1%B4%EA%B4%80%EA%B3%84_%EC%97%AD%EC%A0%84_%EC%9B%90%EC%B9%99">의존관계 역전 원칙(DIP:Dependency Inversion Principle)</a>:상위 모듈은 하위 모듈에 의존하면 안된다. 추상화된 것은 구체화된 것에 의존하면 안된다.</li>
</ol>
위키참고
