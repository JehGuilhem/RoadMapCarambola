package test;

import org.junit.After;
import org.junit.Assert;
import org.junit.Before;
import org.junit.Test;

import app.StringUtil;

public class StringUtilTest {
	
	@Before
	public void before() {
		System.out.println("Iniciando o teste...");
	}
	
	@Test
	public void isEmptyTest() {
		boolean b;
		
		b = StringUtil.isEmpty("abc");
		Assert.assertFalse(b);
		
		b = StringUtil.isEmpty(null);
		Assert.assertTrue(b);
		
		b = StringUtil.isEmpty("");
		Assert.assertTrue(b);
	}
	@Test
	public void reverseTest() {
		
		String r = StringUtil.reverse("abcd");
		Assert.assertEquals("dcba", r);
		
		r = StringUtil.reverse(null);
		Assert.assertNull(r);
	}
	
	@After
	public void after() {
		System.out.println("Teste finalizado.");
	}

}
