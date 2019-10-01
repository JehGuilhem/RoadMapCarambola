package test;

import org.junit.Assert;
import org.junit.Test;

import app.ArrayUtil;

public class ArrayUtilTest {

	@Test
	public void reverseTest() {
		Integer[] numbers = { 1, 2, 3, 4, 5};
		
		ArrayUtil.reverse(numbers);
		
		Integer[] expected = {5, 4, 3, 2, 1};
		
		Assert.assertArrayEquals(expected, numbers);
	}
}
