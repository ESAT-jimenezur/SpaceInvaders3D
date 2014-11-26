using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour {


	public static void createMap(){
		// Create a basic Squares Map
		float starting_point_x_ 	= 0.0f;
		float starting_point_y_ 	= 0.0f;
		float starting_point_z_ 	= 0.0f;
		int map_side_size_			= 20; // --> From center 128x128 blocks

		float drawing_point_x		= starting_point_x_ - (map_side_size_ / 2);
		float drawing_point_z		= starting_point_z_ - (map_side_size_ / 2);


		GameObject map_container = new GameObject();
		map_container.name = "Map";
		for(int i = 0; i < map_side_size_; i++){
			for(int j = 0; j < map_side_size_; j++){
				SimpleProceduralCube simple_procedural_cube = new SimpleProceduralCube();
				GameObject cube = simple_procedural_cube.createCube(new Vector3(drawing_point_x + j, starting_point_y_, drawing_point_z + i), new Vector3(1.0f, 1.0f, 1.0f));
				cube.transform.parent = map_container.transform;
			}
		}

	}

}
