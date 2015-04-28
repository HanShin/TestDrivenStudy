# 테스트 주도개발 연습
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

