#version 330 core
out vec4 FragColor;

in vec2 TexCoord; // Received texture coordinates from vertex shader

uniform sampler2D grassTexture;

void main() {
    FragColor = texture(grassTexture, TexCoord);
}