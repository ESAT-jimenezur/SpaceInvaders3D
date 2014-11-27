using UnityEngine;
using System.Collections;

public class Invader {

	private string invader_name_;

	private static float quad_size;
	private Vector3 cube_size_;
	private float offset_;
	
	
	
	/* 			INVADER
	  
			░░░░░░░░░░░░░░░░░
			░░░░░▀▄░░░▄▀░░░░░
			░░░░▄█▀███▀█▄░░░░
			░░░█▀███████▀█░░░
			░░░█░█▀▀▀▀▀█░█░░░
			░░░░░░▀▀░▀▀░░░░░░
			░░░░░░░░░░░░░░░░░ 
			
		WIDTH : 11	
		HEIGHT: 8 	
		So we create an array [10][7];
	 */
	private const int invader_height_ = 8;
	private const int invader_width_  = 11;
	
	private int[,] invader_array = new int[invader_height_, invader_width_]{
		{0,0,1,0,0,0,0,0,1,0,0},
		{0,0,0,1,0,0,0,1,0,0,0},
		{0,0,1,1,1,1,1,1,1,0,0},
		{0,1,1,0,1,1,1,0,1,1,0},//Ojos
		{1,1,1,1,1,1,1,1,1,1,1},
		{1,0,1,1,1,1,1,1,1,0,1},
		{1,0,1,0,0,0,0,0,1,0,1},
		{0,0,0,1,1,0,1,1,0,0,0}
	};


	public Invader(){
		invader_name_ = "invader";

		quad_size 	=  1.0f;
		cube_size_ 	= new Vector3(quad_size, quad_size, quad_size);
		offset_ 	= 0.0f;
	}


	public GameObject createInvader(){
		GameObject invader_object = new GameObject();
		invader_object.name = invader_name_;
		
		for (int y = 0; y < invader_height_; y++){
			for (int x = 0; x < invader_width_; x++){
				if(invader_array[y, x] == 1){
					//SimpleProceduralCube simple_procedural_cube = new SimpleProceduralCube();
					SimpleProceduralCube simple_procedural_cube = ScriptableObject.CreateInstance("SimpleProceduralCube")as SimpleProceduralCube; // New way to do this, removed above!
					GameObject cube = simple_procedural_cube.createCube(new Vector3(cube_size_.x - x, cube_size_.y - y, 0.0f), cube_size_);
					//GameObject cube = gameObject.GetComponent<SimpleProceduralCube>().createCube(new Vector3(cube_size_.x - x, cube_size_.y - y, 0.0f), cube_size_);
					cube.transform.parent = invader_object.transform;
				}
			}
		}

		return invader_object;
	}
	

	/*
	public GameObject[] createWave(int num){
		GameObject[] invader_array;
		GameObject invader;
		for(int i = 0; i < num; i++){
			invader = createInvader();
			invader_array.SetValue(invader, i);
		}
		return invader_array;
	}
	*/
}
